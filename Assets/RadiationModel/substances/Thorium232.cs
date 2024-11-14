using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thorium232 : RadioactiveSubstance
    {
        public override string name { get; } = "Thorium232";
        public override double halfLife { get; } = 4.41797328e+17d;
        public override double atomicWeight { get; } = 232.03805d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(5101547.4), new Radium228() } },
            { 1.0999999999999999e-11d, new List<RadioactiveSubstance> {  } },
            { 2.7800000000000003e-12d, new List<RadioactiveSubstance> { new Neon24(), new Neon26(), new Ytterbium182() } },

        };
    }
}
    
    