using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bromine72m : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine72m";
        public override double halfLife { get; } = 10.6d;
        public override double atomicWeight { get; } = 71.9367d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bromine72() }, { 0.466d, new GammaParticle(101300.0, 0.01224) }, { 0.011689276d, new GammaParticle(1535.0, 0.80771) }, { 0.08438714825188821d, new GammaParticle(11879.0, 0.10437) }, { 0.16287810895944455d, new GammaParticle(11925.0, 0.10397) }, { 0.03863232713392805d, new GammaParticle(13345.0, 0.09291) }, { 0.0416147427886673d, new GammaParticle(13377.0, 0.09268) }, { 0.0029824156547392454d, new GammaParticle(13469.0, 0.09205) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    