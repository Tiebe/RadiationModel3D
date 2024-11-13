
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Uranium232 : RadioactiveSubstance
    {
        public override string name { get; } = "Uranium232";
        public override double halfLife { get; } = 2174273992.8d;
        public override double atomicWeight { get; } = 232.03715d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Thorium228() } },

            { 8.9e-12d, new List<RadioactiveSubstance> { new Neon24(), new Lead208() } },

            { 2.7e-14d, new List<RadioactiveSubstance> {  } },

            { 4.9999999999999995e-14d, new List<RadioactiveSubstance> { new Magnesium28(), new Mercury204() } },

        };
    }
}
    
    