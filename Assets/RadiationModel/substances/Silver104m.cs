using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver104m : RadioactiveSubstance
    {
        public override string name { get; } = "Silver104m";
        public override double halfLife { get; } = 2010.0d;
        public override double atomicWeight { get; } = 103.90863d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 4286100.0), new Palladium104() } },
            { 0.0007000000000000001d, new List<RadioactiveSubstance> { new GammaParticle((7000.0, 0.17712)), new Silver104() } },

        };
    }
}
    
    