
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fluorine18 : RadioactiveSubstance
    {
        public override string name { get; } = "Fluorine18";
        public override double halfLife { get; } = 6584.04d;
        public override double atomicWeight { get; } = 18.00094d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Oxygen18() } },

        };
    }
}
    
    