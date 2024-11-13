
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten159 : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten159";
        public override double halfLife { get; } = 0.0082d;
        public override double atomicWeight { get; } = 158.9727d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Hafnium155() } },

        };
    }
}
    
    