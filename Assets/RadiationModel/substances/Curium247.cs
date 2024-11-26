using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Curium247 : RadioactiveSubstance
    {
        public override string name { get; } = "Curium247";
        public override double halfLife { get; } = 492288045203635.2d;
        public override double atomicWeight { get; } = 247.07035d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Plutonium243() }, { 1.0d, new AlphaParticle(6375402.09) }, { 0.00035999999999999997d, new GammaParticle(229300.0, 0.00541) }, { 0.034d, new GammaParticle(278000.0, 0.00446) }, { 0.02d, new GammaParticle(287500.0, 0.00431) }, { 0.013000000000000001d, new GammaParticle(346000.0, 0.00358) }, { 0.72d, new GammaParticle(402400.0, 0.00308) }, { 0.01839356953852d, new GammaParticle(17604.0, 0.07043) }, { 0.010306256237840549d, new GammaParticle(99533.0, 0.01246) }, { 0.016315111980118015d, new GammaParticle(103741.0, 0.01195) }, { 0.005988325590231213d, new GammaParticle(117130.0, 0.01059) }, { 0.008066274570041445d, new GammaParticle(118619.0, 0.01045) }, { 0.002077948979810231d, new GammaParticle(120544.0, 0.01029) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    