using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury197m : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury197m";
        public override double halfLife { get; } = 85680.0d;
        public override double atomicWeight { get; } = 196.96753d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.914d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Mercury197() }, { 0.3348d, new GammaParticle(133980.0, 0.00925) }, { 0.0026181359999999996d, new GammaParticle(164970.0, 0.00752) }, { 0.39310613684028d, new GammaParticle(11777.0, 0.10528) }, { 0.09581941116650819d, new GammaParticle(68894.0, 0.018) }, { 0.1624333127081d, new GammaParticle(70820.0, 0.01751) }, { 0.05512587145351265d, new GammaParticle(80316.0, 0.01544) }, { 0.07127775178939186d, new GammaParticle(81285.0, 0.01525) }, { 0.016151880335879207d, new GammaParticle(82477.0, 0.01503) } } },
            { 0.086d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gold197() }, { 0.00028670000000000003d, new GammaParticle(77350.0, 0.01603) }, { 0.0027267000000000003d, new GammaParticle(130200.0, 0.00952) }, { 0.0008906d, new GammaParticle(201800.0, 0.00614) }, { 0.061d, new GammaParticle(279000.0, 0.00444) }, { 9.15e-05d, new GammaParticle(409100.0, 0.00303) }, { 0.05139761642995392d, new GammaParticle(11419.0, 0.10858) }, { 0.02454172368650343d, new GammaParticle(66991.0, 0.01851) }, { 0.04178025823374775d, new GammaParticle(68806.0, 0.01802) }, { 0.014097923232078218d, new GammaParticle(78048.0, 0.01589) }, { 0.018172223046148822d, new GammaParticle(78983.0, 0.0157) }, { 0.004074299814070605d, new GammaParticle(80133.0, 0.01547) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    