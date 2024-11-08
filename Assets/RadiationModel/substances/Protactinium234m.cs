using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Protactinium234m : RadioactiveSubstance
    {
        public override string name { get; } = "Protactinium-234m";
        public override double halfLife { get; } = 1.159 * TimeConstants.SECONDS_IN_MINUTE;
        public override double atomicWeight { get; } = 234.04330;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9984, new List<RadioactiveSubstance>() { new Uranium234(), new ElectronParticle() } },
            { 0.0016, new List<RadioactiveSubstance>() { new Protactinium234(), new GammaParticle()} },
        };
    }
}