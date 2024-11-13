
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nobelium254 : RadioactiveSubstance
    {
        public override string name { get; } = "Nobelium254";
        public override double halfLife { get; } = 51.2d;
        public override double atomicWeight { get; } = 254.09095d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.9d, new List<RadioactiveSubstance> { new AlphaParticle(), new Fermium250() } },

            { 0.1d, new List<RadioactiveSubstance> { new BetaParticle(), new Mendelevium254() } },

            { 0.0017000000000000001d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    