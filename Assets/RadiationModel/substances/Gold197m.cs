using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Gold197m : RadioactiveSubstance
    {
        public override string name { get; } = "Gold197m";
        public override double halfLife { get; } = 7.73d;
        public override double atomicWeight { get; } = 196.96701d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Gold197()), new(0.0029778d, new GammaParticle(77351.0, 0.01603)), new(0.031196d, new GammaParticle(130200.0, 0.00952)), new(0.011344d, new GammaParticle(201600.0, 0.00615)), new(0.7090000000000001d, new GammaParticle(279010.0, 0.00444)), new(0.0010635d, new GammaParticle(409100.0, 0.00303)), new(0.3187873924826528d, new GammaParticle(11419.0, 0.10858)), new(0.07106855206300955d, new GammaParticle(66991.0, 0.01851)), new(0.12098834195268905d, new GammaParticle(68806.0, 0.01802)), new(0.040825127199613204d, new GammaParticle(78048.0, 0.01589)), new(0.052623588960301414d, new GammaParticle(78983.0, 0.0157)), new(0.011798461760688215d, new GammaParticle(80133.0, 0.01547)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    