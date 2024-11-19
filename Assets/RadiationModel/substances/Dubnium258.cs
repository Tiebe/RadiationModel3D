using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dubnium258 : RadioactiveSubstance
    {
        public override string name { get; } = "Dubnium258";
        public override double halfLife { get; } = 2.17d;
        public override double atomicWeight { get; } = 258.10898d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.64d, new List<RadioactiveSubstance> { new AlphaParticle(10457002.09), new Lawrencium254() } },
            { 0.36d, new List<RadioactiveSubstance> { new BetaParticle(1, 5166000.0), new Rutherfordium258() } },

        };
    }
}
    
    