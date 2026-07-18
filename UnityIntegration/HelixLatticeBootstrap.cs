// HelixLattice Unity Integration
// ECS/DOTS entry point for the engine.

using Unity.Entities;

public class HelixLatticeBootstrap : ICustomBootstrap {
    public bool Initialize() {
        // Register all systems: MathCore, Physics, OrbitalSim
        return true;
    }
}