using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class ElectronParticle : RadioactiveSubstance
    {
        public override string name { get; } = "Electron";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 0;
        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new();
    }
}