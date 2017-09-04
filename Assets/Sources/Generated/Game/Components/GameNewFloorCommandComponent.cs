//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public NewFloorCommand newFloorCommand { get { return (NewFloorCommand)GetComponent(GameComponentsLookup.NewFloorCommand); } }
    public bool hasNewFloorCommand { get { return HasComponent(GameComponentsLookup.NewFloorCommand); } }

    public void AddNewFloorCommand(int newLength, UnityEngine.Vector3 newPosition) {
        var index = GameComponentsLookup.NewFloorCommand;
        var component = CreateComponent<NewFloorCommand>(index);
        component.length = newLength;
        component.position = newPosition;
        AddComponent(index, component);
    }

    public void ReplaceNewFloorCommand(int newLength, UnityEngine.Vector3 newPosition) {
        var index = GameComponentsLookup.NewFloorCommand;
        var component = CreateComponent<NewFloorCommand>(index);
        component.length = newLength;
        component.position = newPosition;
        ReplaceComponent(index, component);
    }

    public void RemoveNewFloorCommand() {
        RemoveComponent(GameComponentsLookup.NewFloorCommand);
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

    static Entitas.IMatcher<GameEntity> _matcherNewFloorCommand;

    public static Entitas.IMatcher<GameEntity> NewFloorCommand {
        get {
            if (_matcherNewFloorCommand == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.NewFloorCommand);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherNewFloorCommand = matcher;
            }

            return _matcherNewFloorCommand;
        }
    }
}
