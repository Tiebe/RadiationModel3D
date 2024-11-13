
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Uranium236 : RadioactiveSubstance
    {
        public override string name { get; } = "Uranium236";
        public override double halfLife { get; } = 739063815840000.0d;
        public override double atomicWeight { get; } = 236.04557d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Thorium232() } },

            { 9.399999999999999e-10d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    