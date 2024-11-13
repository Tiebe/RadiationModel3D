
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Livermorium290 : RadioactiveSubstance
    {
        public override string name { get; } = "Livermorium290";
        public override double halfLife { get; } = 0.009d;
        public override double atomicWeight { get; } = 290.19864d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Flerovium286() } },

        };
    }
}
    
    