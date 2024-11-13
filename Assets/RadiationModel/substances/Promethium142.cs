
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium142 : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium142";
        public override double halfLife { get; } = 40.5d;
        public override double atomicWeight { get; } = 141.91289d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Neodymium142() } },

            { 0.7709999999999999d, new List<RadioactiveSubstance> { new BetaParticle(), new Neodymium142() } },

            { 0.22899999999999998d, new List<RadioactiveSubstance> { new Neodymium142() } },

        };
    }
}
    
    