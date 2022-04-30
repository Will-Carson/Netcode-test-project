using Unity.Entities;

[GenerateAuthoringComponent]
public struct CubeSpawner : IComponentData
{
    public Entity Cube;
}