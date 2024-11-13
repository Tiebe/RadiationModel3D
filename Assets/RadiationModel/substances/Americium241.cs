
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Americium241 : RadioactiveSubstance
    {
        public override string name { get; } = "Americium241";
        public override double halfLife { get; } = 13651537435.2d;
        public override double atomicWeight { get; } = 241.05683d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Neptunium237() } },

            { 3.6e-12d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    