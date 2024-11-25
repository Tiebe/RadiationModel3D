using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony115m : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony115m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 114.9096d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Antimony115() }, { 0.22209d, new GammaParticle(157820.0, 0.00786) }, { 0.6729999999999999d, new GammaParticle(279400.0, 0.00444) }, { 0.079414d, new GammaParticle(576500.0, 0.00215) }, { 0.08076d, new GammaParticle(723570.0, 0.00171) }, { 0.703958d, new GammaParticle(1216700.0, 0.00102) }, { 0.9152800000000001d, new GammaParticle(1300250.0, 0.00095) }, { 0.295447d, new GammaParticle(1338230.0, 0.00093) }, { 0.14515454602798564d, new GammaParticle(3941.0, 0.3146) }, { 0.023173089565624628d, new GammaParticle(26111.0, 0.04748) }, { 0.04326566386412365d, new GammaParticle(26359.0, 0.04704) }, { 0.01230795796759877d, new GammaParticle(29821.0, 0.04158) }, { 0.014855705266891717d, new GammaParticle(30069.0, 0.04123) }, { 0.002547747299292946d, new GammaParticle(30387.0, 0.0408) } } },

        };
    }
}
    