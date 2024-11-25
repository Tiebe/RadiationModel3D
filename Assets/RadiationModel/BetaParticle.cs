using System.Collections.Generic;
using RadiationModel.substances;

namespace RadiationModel
{
    public class BetaParticle : RadioactiveSubstance
    {
        public BetaParticle(int charge, double energy) => (this.charge, this.energy) = (charge, energy);
        public override string name => "Electron";
        public override double halfLife => double.PositiveInfinity;
        public override double atomicWeight => 0;
        public double energy { get; set; }
        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new();
    }
}