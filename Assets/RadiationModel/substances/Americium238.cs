
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Americium238 : RadioactiveSubstance
    {
        public override string name { get; } = "Americium238";
        public override double halfLife { get; } = 5880.0d;
        public override double atomicWeight { get; } = 238.05198d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Plutonium238() } },

            { 1e-06d, new List<RadioactiveSubstance> { new AlphaParticle(), new Neptunium234() } },

        };
    }
}
    
    