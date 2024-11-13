
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Moscovium289 : RadioactiveSubstance
    {
        public override string name { get; } = "Moscovium289";
        public override double halfLife { get; } = 0.41d;
        public override double atomicWeight { get; } = 289.19397d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Nihonium285() } },

        };
    }
}
    
    