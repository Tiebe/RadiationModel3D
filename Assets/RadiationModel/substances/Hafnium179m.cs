using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium179m : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium179m";
        public override double halfLife { get; } = 18.67d;
        public override double atomicWeight { get; } = 178.94623d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00331), new Hafnium179() } },

        };
    }
}
    
    