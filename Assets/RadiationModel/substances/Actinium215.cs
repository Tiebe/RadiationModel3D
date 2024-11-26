using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Actinium215 : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium215";
        public override double halfLife { get; } = 0.17d;
        public override double atomicWeight { get; } = 215.00647d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9991d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Francium211() }, { 1.0d, new AlphaParticle(8768002.09) }, { 9e-06d, new GammaParticle(110100.0, 0.01126) }, { 2e-05d, new GammaParticle(237200.0, 0.00523) }, { 0.00015d, new GammaParticle(342600.0, 0.00362) }, { 0.0022d, new GammaParticle(395800.0, 0.00313) }, { 6e-05d, new GammaParticle(505900.0, 0.00245) }, { 0.0012d, new GammaParticle(583200.0, 0.00213) }, { 5e-05d, new GammaParticle(633100.0, 0.00196) }, { 0.0007000000000000001d, new GammaParticle(652600.0, 0.0019) }, { 0.00010999999999999999d, new GammaParticle(739200.0, 0.00168) }, { 8.698775316e-05d, new GammaParticle(14500.0, 0.08551) }, { 5.888374415738099e-05d, new GammaParticle(83227.0, 0.0149) }, { 9.665749205085521e-05d, new GammaParticle(86102.0, 0.0144) }, { 3.3716264948462076e-05d, new GammaParticle(97469.0, 0.01272) }, { 4.464033479176379e-05d, new GammaParticle(98682.0, 0.01256) }, { 1.0924069843301714e-05d, new GammaParticle(100209.0, 0.01237) } } },
            { 0.0009d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Francium215() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    