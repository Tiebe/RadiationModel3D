
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radon203m : RadioactiveSubstance
    {
        public override string name { get; } = "Radon203m";
        public override double halfLife { get; } = 26.9d;
        public override double atomicWeight { get; } = 202.99375d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.75d, new List<RadioactiveSubstance> { new AlphaParticle(), new Polonium199() } },

            { 0.25d, new List<RadioactiveSubstance> { new BetaParticle(), new Astatine203() } },

        };
    }
}
    
    