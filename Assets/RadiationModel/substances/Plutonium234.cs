
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Plutonium234 : RadioactiveSubstance
    {
        public override string name { get; } = "Plutonium234";
        public override double halfLife { get; } = 31680.0d;
        public override double atomicWeight { get; } = 234.04332d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.94d, new List<RadioactiveSubstance> { new Neptunium234() } },

            { 0.06d, new List<RadioactiveSubstance> { new AlphaParticle(), new Uranium230() } },

        };
    }
}
    
    