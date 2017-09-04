//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameContext {

    public GameEntity viewContainerEntity { get { return GetGroup(GameMatcher.ViewContainer).GetSingleEntity(); } }
    public ViewContainerComponent viewContainer { get { return viewContainerEntity.viewContainer; } }
    public bool hasViewContainer { get { return viewContainerEntity != null; } }

    public GameEntity SetViewContainer(UnityEngine.Transform newValue) {
        if (hasViewContainer) {
            throw new Entitas.EntitasException("Could not set ViewContainer!\n" + this + " already has an entity with ViewContainerComponent!",
                "You should check if the context already has a viewContainerEntity before setting it or use context.ReplaceViewContainer().");
        }
        var entity = CreateEntity();
        entity.AddViewContainer(newValue);
        return entity;
    }

    public void ReplaceViewContainer(UnityEngine.Transform newValue) {
        var entity = viewContainerEntity;
        if (entity == null) {
            entity = SetViewContainer(newValue);
        } else {
            entity.ReplaceViewContainer(newValue);
        }
    }

    public void RemoveViewContainer() {
        viewContainerEntity.Destroy();
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

    public ViewContainerComponent viewContainer { get { return (ViewContainerComponent)GetComponent(GameComponentsLookup.ViewContainer); } }
    public bool hasViewContainer { get { return HasComponent(GameComponentsLookup.ViewContainer); } }

    public void AddViewContainer(UnityEngine.Transform newValue) {
        var index = GameComponentsLookup.ViewContainer;
        var component = CreateComponent<ViewContainerComponent>(index);
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceViewContainer(UnityEngine.Transform newValue) {
        var index = GameComponentsLookup.ViewContainer;
        var component = CreateComponent<ViewContainerComponent>(index);
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveViewContainer() {
        RemoveComponent(GameComponentsLookup.ViewContainer);
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

    static Entitas.IMatcher<GameEntity> _matcherViewContainer;

    public static Entitas.IMatcher<GameEntity> ViewContainer {
        get {
            if (_matcherViewContainer == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.ViewContainer);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherViewContainer = matcher;
            }

            return _matcherViewContainer;
        }
    }
}
