
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium155m : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium155m";
        public override double halfLife { get; } = 0.138d;
        public override double atomicWeight { get; } = 154.95435d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.76d, new List<RadioactiveSubstance> { new AlphaParticle(), new Thulium151() } },

            { 0.24d, new List<RadioactiveSubstance> { new BetaParticle(), new Ytterbium155() } },

        };
    }
}
    
    