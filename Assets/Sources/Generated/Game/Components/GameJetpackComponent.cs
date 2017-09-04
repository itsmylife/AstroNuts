//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameContext {

    public GameEntity jetpackEntity { get { return GetGroup(GameMatcher.Jetpack).GetSingleEntity(); } }
    public JetpackComponent jetpack { get { return jetpackEntity.jetpack; } }
    public bool hasJetpack { get { return jetpackEntity != null; } }

    public GameEntity SetJetpack(int newPower) {
        if (hasJetpack) {
            throw new Entitas.EntitasException("Could not set Jetpack!\n" + this + " already has an entity with JetpackComponent!",
                "You should check if the context already has a jetpackEntity before setting it or use context.ReplaceJetpack().");
        }
        var entity = CreateEntity();
        entity.AddJetpack(newPower);
        return entity;
    }

    public void ReplaceJetpack(int newPower) {
        var entity = jetpackEntity;
        if (entity == null) {
            entity = SetJetpack(newPower);
        } else {
            entity.ReplaceJetpack(newPower);
        }
    }

    public void RemoveJetpack() {
        jetpackEntity.Destroy();
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public JetpackComponent jetpack { get { return (JetpackComponent)GetComponent(GameComponentsLookup.Jetpack); } }
    public bool hasJetpack { get { return HasComponent(GameComponentsLookup.Jetpack); } }

    public void AddJetpack(int newPower) {
        var index = GameComponentsLookup.Jetpack;
        var component = CreateComponent<JetpackComponent>(index);
        component.power = newPower;
        AddComponent(index, component);
    }

    public void ReplaceJetpack(int newPower) {
        var index = GameComponentsLookup.Jetpack;
        var component = CreateComponent<JetpackComponent>(index);
        component.power = newPower;
        ReplaceComponent(index, component);
    }

    public void RemoveJetpack() {
        RemoveComponent(GameComponentsLookup.Jetpack);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherJetpack;

    public static Entitas.IMatcher<GameEntity> Jetpack {
        get {
            if (_matcherJetpack == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Jetpack);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherJetpack = matcher;
            }

            return _matcherJetpack;
        }
    }
}