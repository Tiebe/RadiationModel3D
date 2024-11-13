
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum156m : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum156m";
        public override double halfLife { get; } = 0.36d;
        public override double atomicWeight { get; } = 155.97218d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.958d, new List<RadioactiveSubstance> { new BetaParticle(), new Hafnium156() } },

            { 0.042d, new List<RadioactiveSubstance> { new ProtonParticle(), new Hafnium155() } },

        };
    }
}
    
    