using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum183m : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum183m";
        public override double halfLife { get; } = 43.0d;
        public override double atomicWeight { get; } = 182.96163d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9690000000000001d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Osmium183() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) }, { 1.104e-05d, new GammaParticle(16000.0, 0.07749) }, { 0.07200000000000001d, new GammaParticle(313200.0, 0.00396) }, { 0.13699999999999998d, new GammaParticle(316400.0, 0.00392) }, { 0.09300000000000001d, new GammaParticle(329000.0, 0.00377) }, { 0.259d, new GammaParticle(629600.0, 0.00197) }, { 0.06d, new GammaParticle(645300.0, 0.00192) }, { 0.28d, new GammaParticle(511000.0, 0.00243) }, { 0.18714738414020002d, new GammaParticle(10728.0, 0.11557) }, { 0.09433429120313468d, new GammaParticle(63287.0, 0.01959) }, { 0.16189169590378355d, new GammaParticle(64896.0, 0.01911) }, { 0.05432070810060932d, new GammaParticle(73637.0, 0.01684) }, { 0.06969346849308175d, new GammaParticle(74510.0, 0.01664) }, { 0.01537276039247244d, new GammaParticle(75576.0, 0.01641) } } },
            { 0.031d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Platinum183() }, { 1.8e-07d, new GammaParticle(35000.0, 0.03542) }, { 0.0072647879999999995d, new GammaParticle(11070.0, 0.112) } } },
            { 2.9999999999999997e-06d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Osmium179() }, { 1.0d, new AlphaParticle(5879002.09) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    