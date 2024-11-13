
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gadolinium161 : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium161";
        public override double halfLife { get; } = 218.76d;
        public override double atomicWeight { get; } = 160.92968d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Terbium161() } },

        };
    }
}
    
    