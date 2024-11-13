
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine198 : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine198";
        public override double halfLife { get; } = 4.47d;
        public override double atomicWeight { get; } = 197.9928d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.97d, new List<RadioactiveSubstance> { new AlphaParticle(), new Bismuth194() } },

        };
    }
}
    
    