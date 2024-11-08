using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Protactinium234 : RadioactiveSubstance
    {
        public override string name { get; } = "Protactinium-234";
        public override double halfLife { get; } = 6.69 * TimeConstants.SECONDS_IN_HOUR;
        public override double atomicWeight { get; } = 234.04330;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1, new List<RadioactiveSubstance> { new Uranium234(), new ElectronParticle()} }
        };
    }
}