using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Mercury197m : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury197m";
        public override double halfLife { get; } = 85680.0d;
        public override double atomicWeight { get; } = 196.96753d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.914d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Mercury197()), new(0.3348d, new GammaParticle(133980.0, 0.00925)), new(0.0026181359999999996d, new GammaParticle(164970.0, 0.00752)), new(0.39310613684028d, new GammaParticle(11777.0, 0.10528)), new(0.09581941116650819d, new GammaParticle(68894.0, 0.018)), new(0.1624333127081d, new GammaParticle(70820.0, 0.01751)), new(0.05512587145351265d, new GammaParticle(80316.0, 0.01544)), new(0.07127775178939186d, new GammaParticle(81285.0, 0.01525)), new(0.016151880335879207d, new GammaParticle(82477.0, 0.01503)) } },
            { 0.086d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Gold197()), new(0.00028670000000000003d, new GammaParticle(77350.0, 0.01603)), new(0.0027267000000000003d, new GammaParticle(130200.0, 0.00952)), new(0.0008906d, new GammaParticle(201800.0, 0.00614)), new(0.061d, new GammaParticle(279000.0, 0.00444)), new(9.15e-05d, new GammaParticle(409100.0, 0.00303)), new(0.05139761642995392d, new GammaParticle(11419.0, 0.10858)), new(0.02454172368650343d, new GammaParticle(66991.0, 0.01851)), new(0.04178025823374775d, new GammaParticle(68806.0, 0.01802)), new(0.014097923232078218d, new GammaParticle(78048.0, 0.01589)), new(0.018172223046148822d, new GammaParticle(78983.0, 0.0157)), new(0.004074299814070605d, new GammaParticle(80133.0, 0.01547)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    