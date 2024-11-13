
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine202m : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine202m";
        public override double halfLife { get; } = 182.0d;
        public override double atomicWeight { get; } = 201.98883d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.915d, new List<RadioactiveSubstance> { new BetaParticle(), new Polonium202() } },

            { 0.085d, new List<RadioactiveSubstance> { new AlphaParticle(), new Bismuth198() } },

        };
    }
}
    
    