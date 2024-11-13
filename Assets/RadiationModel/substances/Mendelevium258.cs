
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mendelevium258 : RadioactiveSubstance
    {
        public override string name { get; } = "Mendelevium258";
        public override double halfLife { get; } = 4457376.0d;
        public override double atomicWeight { get; } = 258.09843d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Einsteinium254() } },

            { 1.5e-05d, new List<RadioactiveSubstance> { new BetaParticle(), new Fermium258() } },

            { 1.5e-05d, new List<RadioactiveSubstance> { new BetaParticle(), new Nobelium258() } },

        };
    }
}
    
    