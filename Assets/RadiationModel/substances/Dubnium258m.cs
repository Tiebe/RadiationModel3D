using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dubnium258m : RadioactiveSubstance
    {
        public override string name { get; } = "Dubnium258m";
        public override double halfLife { get; } = 4.41d;
        public override double atomicWeight { get; } = 258.10903d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.77d, new List<RadioactiveSubstance> { new AlphaParticle(10505047.4), new Lawrencium254() } },
            { 0.23d, new List<RadioactiveSubstance> { new BetaParticle(1, 5216000.0), new Rutherfordium258() } },

        };
    }
}
    
    