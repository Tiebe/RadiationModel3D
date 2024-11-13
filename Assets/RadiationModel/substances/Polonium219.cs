
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium219 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium219";
        public override double halfLife { get; } = 618.0d;
        public override double atomicWeight { get; } = 219.01361d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.718d, new List<RadioactiveSubstance> { new BetaParticle(), new Astatine219() } },

            { 0.282d, new List<RadioactiveSubstance> { new AlphaParticle(), new Lead215() } },

        };
    }
}
    
    