using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold197m : RadioactiveSubstance
    {
        public override string name { get; } = "Gold197m";
        public override double halfLife { get; } = 7.73d;
        public override double atomicWeight { get; } = 196.96701d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gold197() }, { 0.0029778d, new GammaParticle(77351.0, 0.01603) }, { 0.031196d, new GammaParticle(130200.0, 0.00952) }, { 0.011344d, new GammaParticle(201600.0, 0.00615) }, { 0.7090000000000001d, new GammaParticle(279010.0, 0.00444) }, { 0.0010635d, new GammaParticle(409100.0, 0.00303) }, { 0.3187873924826528d, new GammaParticle(11419.0, 0.10858) }, { 0.07106855206300955d, new GammaParticle(66991.0, 0.01851) }, { 0.12098834195268905d, new GammaParticle(68806.0, 0.01802) }, { 0.040825127199613204d, new GammaParticle(78048.0, 0.01589) }, { 0.052623588960301414d, new GammaParticle(78983.0, 0.0157) }, { 0.011798461760688215d, new GammaParticle(80133.0, 0.01547) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    