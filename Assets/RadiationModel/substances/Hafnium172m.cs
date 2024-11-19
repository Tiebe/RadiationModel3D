using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium172m : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium172m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 171.9416d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((2006000.0, 0.00062)), new Hafnium172() } },

        };
    }
}
    
    