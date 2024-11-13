
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Californium242 : RadioactiveSubstance
    {
        public override string name { get; } = "Californium242";
        public override double halfLife { get; } = 209.4d;
        public override double atomicWeight { get; } = 242.06375d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.61d, new List<RadioactiveSubstance> { new AlphaParticle(), new Curium238() } },

            { 0.39d, new List<RadioactiveSubstance> { new BetaParticle(), new Berkelium242() } },

            { 0.00014000000000000001d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    