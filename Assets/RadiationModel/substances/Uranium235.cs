
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Uranium235 : RadioactiveSubstance
    {
        public override string name { get; } = "Uranium235";
        public override double halfLife { get; } = 2.2216094208e+16d;
        public override double atomicWeight { get; } = 235.04393d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Thorium231() } },

            { 7e-11d, new List<RadioactiveSubstance> {  } },

            { 8e-12d, new List<RadioactiveSubstance> { new Neon20(), new Lead215() } },

            { 8e-12d, new List<RadioactiveSubstance> { new Neon25(), new Lead210() } },

            { 8e-12d, new List<RadioactiveSubstance> { new Magnesium28(), new Mercury207() } },

        };
    }
}
    
    