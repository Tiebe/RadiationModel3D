
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine209 : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine209";
        public override double halfLife { get; } = 19512.0d;
        public override double atomicWeight { get; } = 208.98617d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.961d, new List<RadioactiveSubstance> { new BetaParticle(), new Polonium209() } },

            { 0.039d, new List<RadioactiveSubstance> { new AlphaParticle(), new Bismuth205() } },

        };
    }
}
    
    