using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium207 : RadioactiveSubstance
    {
        public override string name { get; } = "Radium207";
        public override double halfLife { get; } = 1.38d;
        public override double atomicWeight { get; } = 207.00377d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.86d, new List<RadioactiveSubstance> { new AlphaParticle(8289047.399999999), new Radon203() } },

        };
    }
}
    
    