
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Curium241 : RadioactiveSubstance
    {
        public override string name { get; } = "Curium241";
        public override double halfLife { get; } = 2833920.0d;
        public override double atomicWeight { get; } = 241.05765d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.99d, new List<RadioactiveSubstance> { new Americium241() } },

            { 0.01d, new List<RadioactiveSubstance> { new AlphaParticle(), new Plutonium237() } },

        };
    }
}
    
    