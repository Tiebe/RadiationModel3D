
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum156 : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum156";
        public override double halfLife { get; } = 0.106d;
        public override double atomicWeight { get; } = 155.97209d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.71d, new List<RadioactiveSubstance> { new ProtonParticle(), new Hafnium155() } },

            { 0.29d, new List<RadioactiveSubstance> { new BetaParticle(), new Hafnium156() } },

        };
    }
}
    
    