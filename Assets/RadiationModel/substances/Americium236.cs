
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Americium236 : RadioactiveSubstance
    {
        public override string name { get; } = "Americium236";
        public override double halfLife { get; } = 216.0d;
        public override double atomicWeight { get; } = 236.04943d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Plutonium236() } },

            { 4e-05d, new List<RadioactiveSubstance> { new AlphaParticle(), new Neptunium232() } },

        };
    }
}
    
    