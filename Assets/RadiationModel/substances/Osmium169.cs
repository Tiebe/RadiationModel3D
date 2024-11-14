using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium169 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium169";
        public override double halfLife { get; } = 3.46d;
        public override double atomicWeight { get; } = 168.96702d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.863d, new List<RadioactiveSubstance> { new BetaParticle(1, 7686000.0), new Rhenium169() } },
            { 0.13699999999999998d, new List<RadioactiveSubstance> { new AlphaParticle(6733047.4), new Tungsten165() } },

        };
    }
}
    
    