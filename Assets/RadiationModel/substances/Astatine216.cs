using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine216 : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine216";
        public override double halfLife { get; } = 0.0003d;
        public override double atomicWeight { get; } = 216.00242d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(8969947.399999999), new Bismuth212() } },

        };
    }
}
    
    