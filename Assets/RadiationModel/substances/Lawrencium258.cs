using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lawrencium258 : RadioactiveSubstance
    {
        public override string name { get; } = "Lawrencium258";
        public override double halfLife { get; } = 3.92d;
        public override double atomicWeight { get; } = 258.10175d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9740000000000001d, new List<RadioactiveSubstance> { new AlphaParticle(9925047.4), new Mendelevium254() } },
            { 0.026000000000000002d, new List<RadioactiveSubstance> { new BetaParticle(1, 3300000.0), new Nobelium258() } },

        };
    }
}
    
    