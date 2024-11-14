using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium174 : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium174";
        public override double halfLife { get; } = 6.3113904e+22d;
        public override double atomicWeight { get; } = 173.94005d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(3514376.4), new Ytterbium170() } },

        };
    }
}
    
    