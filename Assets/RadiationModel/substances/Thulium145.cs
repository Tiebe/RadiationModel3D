
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium145 : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium145";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 144.97039d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new ProtonParticle(), new Erbium144() } },

        };
    }
}
    
    