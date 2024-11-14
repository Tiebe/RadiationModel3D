using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium192 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium192";
        public override double halfLife { get; } = 6378048.0d;
        public override double atomicWeight { get; } = 191.9626d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9523999999999999d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1452900.0), new Platinum192() } },
            { 0.047599999999999996d, new List<RadioactiveSubstance> { new Osmium192() } },

        };
    }
}
    
    