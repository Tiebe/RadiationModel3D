using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin128m : RadioactiveSubstance
    {
        public override string name { get; } = "Tin128m";
        public override double halfLife { get; } = 6.5d;
        public override double atomicWeight { get; } = 127.91275d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tin128() }, { 0.036000000000000004d, new GammaParticle(91150.0, 0.0136) }, { 1.0d, new GammaParticle(831540.0, 0.00149) }, { 1.0d, new GammaParticle(1168800.0, 0.00106) }, { 0.056266225600000004d, new GammaParticle(3753.0, 0.33036) }, { 0.07154635192176487d, new GammaParticle(25044.0, 0.04951) }, { 0.1339067039523954d, new GammaParticle(25271.0, 0.04906) }, { 0.037863779553750844d, new GammaParticle(28579.0, 0.04338) }, { 0.04532294412583976d, new GammaParticle(28810.0, 0.04304) }, { 0.007459164572088917d, new GammaParticle(29107.0, 0.0426) } } },

        };
    }
}
    