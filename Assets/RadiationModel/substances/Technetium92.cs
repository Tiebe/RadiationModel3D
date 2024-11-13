
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium92 : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium92";
        public override double halfLife { get; } = 255.0d;
        public override double atomicWeight { get; } = 91.91527d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Molybdenum92() } },

        };
    }
}
    
    