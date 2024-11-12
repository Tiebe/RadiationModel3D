using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class ElectronParticle : RadioactiveSubstance
    {
        public ElectronParticle() => charge = -1;
        public ElectronParticle(double energy) => this.energy = energy;
        public override string name => "Electron";
        public override double halfLife => double.PositiveInfinity;
        public override double atomicWeight => 0;
        public double energy { get; }
        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new();
    }
}