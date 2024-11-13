
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Oxygen21 : RadioactiveSubstance
    {
        public override string name { get; } = "Oxygen21";
        public override double halfLife { get; } = 3.42d;
        public override double atomicWeight { get; } = 21.00865d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Fluorine21() } },

        };
    }
}
    
    