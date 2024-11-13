
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten167 : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten167";
        public override double halfLife { get; } = 19.9d;
        public override double atomicWeight { get; } = 166.95481d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.9995999999999999d, new List<RadioactiveSubstance> { new BetaParticle(), new Tantalum167() } },

            { 0.0004d, new List<RadioactiveSubstance> { new AlphaParticle(), new Hafnium163() } },

        };
    }
}
    
    