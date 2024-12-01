using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Platinum183m : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum183m";
        public override double halfLife { get; } = 43.0d;
        public override double atomicWeight { get; } = 182.96163d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9690000000000001d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Osmium183()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(1.104e-05d, new GammaParticle(16000.0, 0.07749)), new(0.07200000000000001d, new GammaParticle(313200.0, 0.00396)), new(0.13699999999999998d, new GammaParticle(316400.0, 0.00392)), new(0.09300000000000001d, new GammaParticle(329000.0, 0.00377)), new(0.259d, new GammaParticle(629600.0, 0.00197)), new(0.06d, new GammaParticle(645300.0, 0.00192)), new(0.28d, new GammaParticle(511000.0, 0.00243)), new(0.18714738414020002d, new GammaParticle(10728.0, 0.11557)), new(0.09433429120313468d, new GammaParticle(63287.0, 0.01959)), new(0.16189169590378355d, new GammaParticle(64896.0, 0.01911)), new(0.05432070810060932d, new GammaParticle(73637.0, 0.01684)), new(0.06969346849308175d, new GammaParticle(74510.0, 0.01664)), new(0.01537276039247244d, new GammaParticle(75576.0, 0.01641)) } },
            { 0.031d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Platinum183()), new(1.8e-07d, new GammaParticle(35000.0, 0.03542)), new(0.0072647879999999995d, new GammaParticle(11070.0, 0.112)) } },
            { 2.9999999999999997e-06d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Osmium179()), new(1.0d, new AlphaParticle(5879002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    