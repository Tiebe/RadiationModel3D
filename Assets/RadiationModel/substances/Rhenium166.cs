
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium166 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium166";
        public override double halfLife { get; } = 2.25d;
        public override double atomicWeight { get; } = 165.96582d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.88d, new List<RadioactiveSubstance> { new BetaParticle(), new Tungsten166() } },

            { 0.12d, new List<RadioactiveSubstance> { new AlphaParticle(), new Tantalum162() } },

        };
    }
}
    
    